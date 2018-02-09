using Application.Unit.Dto;
using Core;
using System;
using System.Collections.Generic;
using System.IO;
using System.Web;
using System.Web.Mvc;
using ICSharpCode.SharpZipLib.Core;
using ICSharpCode.SharpZipLib.Zip;

namespace Web.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            return View();
        }
        public JsonResult GetList()
        {
            var list = new ListDto<Student>();
            var l = new List<Student>();
            l.Add(new Student { No = "1400170322", Name = "梁城月", Gender = "男" });
            l.Add(new Student { No = "1400170322", Name = "lcy", Gender = "男" });
            list.rows = l;
            list.results = 2;
            return Json(list, JsonRequestBehavior.AllowGet);
        }
        public ActionResult Load()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Upload(HttpPostedFileBase filedata)
        {
            if (filedata != null && filedata.ContentLength > 0)
            {
                //文件上传后的保存根路径 
                string filePath = Server.MapPath("~/UploadImg/");
                if (!Directory.Exists(filePath))
                {
                    Directory.CreateDirectory(filePath);
                }
                string fileName = Path.GetFileName(filedata.FileName);//获取文件原名
                string fileExtension = Path.GetExtension(fileName);//获取文件扩展名
                string saveFileName = Guid.NewGuid().ToString() + fileExtension;//要保存的文件名称
                int fileSize = filedata.ContentLength / 1024;
                if (fileSize > 1024 || fileSize <= 2)
                {
                    return Json(new { ret = false, message = "文件上传失败，请选择小于1M的图片" });
                }
                else
                {
                    filedata.SaveAs(filePath + saveFileName);
                    return Json(new { ret = true, FilePath = "/UploadImg/" + saveFileName });
                }
            }
            else
            {
                return Json(new { ret = false, message = "请选择要上传的文件" });
            }
        }
        public ActionResult DownZip()
        {
            string path = "~";
            if (!Directory.Exists(Server.MapPath("~/Zip")))
            {
                List<string> list = new List<string>();
                list.Add(@"D:\print.txt");
                list.Add(@"D:\print - 副本.txt");
                Directory.CreateDirectory(Server.MapPath("~/Zip"));
                try
                {
                    List<string> filenames = new List<string>();
                    using (FileStream fs=System.IO.File.Create(Server.MapPath(path+".zip")))
                    {
                        using (ZipOutputStream zips=new ZipOutputStream(fs))
                        {
                            foreach (var item in list)
                            {
                                FileInfo fi = new FileInfo(item);
                                string entryname = System.IO.Path.GetFileName(item);
                                ZipEntry zipEntry = new ZipEntry(entryname);
                                zipEntry.DateTime = fi.LastWriteTime;
                                zipEntry.Size = fi.Length;
                                zips.PutNextEntry(zipEntry);
                                byte[] buffer = new byte[4096];
                                using (FileStream streamReader = System.IO.File.OpenRead(item))
                                {
                                }
                                zips.CloseEntry();
                            }
                            zips.IsStreamOwner = false;
                            zips.Finish();
                            zips.Close();
                        }
                    }
                }
                catch (Exception)
                {

                    throw;
                }
                
            }
            return File(Server.MapPath(path), "application/zip", "免冠照片.zip");
        }
    }
}