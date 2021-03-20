using Core.Utilities.Results;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Core.Utilities.Helpers
{
    public class ImageWriterHelper
    {
        public static string UploadImage(IFormFile file)
        {
            string sPath = Path.GetTempFileName();

            if (file.Length > 0 && CheckIfImageFile(file))
            {
                using (var fileStream = new FileStream(sPath, FileMode.Create))
                {
                    file.CopyTo(fileStream);
                }
            }
            string fn = WriteNewFilePath(file);
            File.Move(sPath, fn);
            return fn;
        }

        public static IResult Delete(string sPath)
        {
            File.Delete(sPath);
            return new SuccessResult();
        }

        public static string Update(string sPath,IFormFile file)
        {
            string conclusion = WriteNewFilePath(file);
            if (sPath.Length > 0)
            {
                using (var fileStream = new FileStream(conclusion, FileMode.Create))
                {
                    file.CopyTo(fileStream);
                }
            }

            File.Delete(sPath);
            return conclusion;
        }

        public enum ImageFormat
        {
            bmp,
            jpeg,
            gif,
            png,
            unkown
        }
        public static ImageFormat GetImageFormat(byte[] bytes)
        {
            var bmp = Encoding.ASCII.GetBytes("BMP");
            var gif = Encoding.ASCII.GetBytes("GIF");
            var png = new byte[] { 137, 80, 78, 71 };
            var jpeg = new byte[] { 255, 216, 255, 224 };

            if (bmp.SequenceEqual(bytes.Take(bmp.Length)))
                return ImageFormat.bmp;
            if (gif.SequenceEqual(bytes.Take(gif.Length)))
                return ImageFormat.gif;
            if (png.SequenceEqual(bytes.Take(png.Length)))
                return ImageFormat.png;
            if (jpeg.SequenceEqual(bytes.Take(jpeg.Length)))
                return ImageFormat.jpeg;

            return ImageFormat.unkown;
        }

        private static bool CheckIfImageFile(IFormFile file)
        {
            byte[] fileBytes;
            using (var ms = new MemoryStream())
            {
                file.CopyTo(ms);
                fileBytes = ms.ToArray();
            }
            return GetImageFormat(fileBytes) != ImageFormat.unkown;
        }

        public static string WriteNewFilePath(IFormFile file)
        {
            FileInfo fileInfo = new FileInfo(file.FileName);
            string fileExtension = fileInfo.Extension;

            string newPath = Guid.NewGuid().ToString() + fileExtension;
            string path = Environment.CurrentDirectory + @"\wwwroot\Images";

            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }

            string result = $@"{path}\{newPath}";
            return result;
        }
        public static void File_Stream(IFormFile file, string result)
        {
            using (var fileStream = new FileStream(result, FileMode.Create))
            {
                file.CopyTo(fileStream);
            }
        }
    }
}
