﻿using Emgu.CV;
using Emgu.CV.Structure;
using EvilDICOM.Core;
using EvilDICOM.Core.Element;
using EvilDICOM.Core.Helpers;
using EvilDICOM.Core.IO.Reading;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SampleDatabaseWalkthrough
{
    public class ConvertHelper
    {
        public static Image<Gray, double> Read(string fileName)
        {
            var dicomData = DICOMFileReader.Read(fileName);

            return Read(dicomData);
        }

        public static Image<Gray, double> Read(byte[] data)
        {
            var dicomData = DICOMFileReader.Read(data);

            return Read(dicomData);
        }

        public static void Write(Image<Gray, double> image, string fileName)
        {
            var width = new UnsignedShort(TagHelper.ROWS, image.Height);
            var height = new UnsignedShort(TagHelper.COLUMNS, image.Width);

            var interp = new CodeString(TagHelper.PHOTOMETRIC_INTERPRETATION, "MONOCHROME2");
            
            var dObj = new DICOMObject(new List<EvilDICOM.Core.Interfaces.IDICOMElement>{
                width,
                height,
                interp
            });

            using (var writer = new EvilDICOM.Core.IO.Writing.DICOMBinaryWriter(fileName))
            {
                var setting = new EvilDICOM.Core.IO.Writing.DICOMWriteSettings()
                {
                };

                EvilDICOM.Core.IO.Writing.DICOMObjectWriter.WriteObjectLittleEndian(writer, setting, dObj);
            }

            using(var memoryStream = new MemoryStream())
            {
                for (int y = 0; y < image.Height; y++)
                {
                    for (int x = 0; x < image.Width; x++)
                    {
                        double pixelIntensity = image[y, x].Intensity;

                        byte firstPixelByte = (byte)(pixelIntensity / 256);
                        byte secondPixelByte = (byte)(pixelIntensity % 256);

                        memoryStream.WriteByte(firstPixelByte);
                        memoryStream.WriteByte(secondPixelByte);
                    }
                }

                memoryStream.Position = 0;

                using (var fileStream = new FileStream(fileName, FileMode.Append, FileAccess.Write))
                {
                    memoryStream.CopyTo(fileStream);
                }
            }
        }

        private static Image<Gray, double> Read(DICOMObject dicomData)
        {
            ushort height = ((UnsignedShort)dicomData.FindFirst(TagHelper.ROWS)).Data;
            ushort width = ((UnsignedShort)dicomData.FindFirst(TagHelper.COLUMNS)).Data;

            var interp = ((CodeString)dicomData.FindFirst(TagHelper.PHOTOMETRIC_INTERPRETATION)).Data;

            if (interp == "MONOCHROME2")
            {
                var image = new Image<Gray, double>(width, height);

                const int bytesPerPixel = 2;

                using (var memstream = new MemoryStream())
                {
                    dicomData.PixelStream.CopyTo(memstream);
                    memstream.Position = 0;

                    byte[] buffer = new byte[width * bytesPerPixel];

                    for (int y = 0; y < height; y++)
                    {
                        memstream.Read(buffer, 0, width * bytesPerPixel);

                        for (int x = 0; x < width; x++)
                        {
                            var pixel = image[y, x];

                            double intensity = 0;

                            for (int i = 0; i < bytesPerPixel; i++)
                            {
                                int offset = bytesPerPixel - i - 1;
                                intensity = intensity * 256 + buffer[x * bytesPerPixel + offset];
                            }

                            intensity = intensity / 16;

                            pixel.Intensity = intensity;
                            image[y, x] = pixel;
                        }
                    }
                }
                return image;
            }
            throw new NotImplementedException();
        }
    }
}
