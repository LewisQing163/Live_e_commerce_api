using Live_e_commerce.Common;
using Live_e_commerce.IQiNiu;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Qiniu.Http;
using Qiniu.Storage;
using Qiniu.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;
using static System.Net.WebRequestMethods;

namespace Live_e_commerce.QiNiu
{
    public class QiNiuService : ApplicationService
    {
        [HttpPost, Route("Upload_qiniu")]
        public string Upload_qiniu(IFormFile filename)
        {

            //扩展名
            //var extname = filename.FileName.Substring(filename.FileName.LastIndexOf('.'), filename.FileName.Length - filename.FileName.LastIndexOf('.'));

            //extname = extname.Replace("\"", "");
            StringBuilder sb = new StringBuilder();
            string AccessKey = "T1BPwVrGFlBfnXJMTrISFw4qTfdjDJUAj-1eFtxX";
            string SccessKey = "Nsty-r3TUCpDKVOeWossfU3ASdVagm4ddDvXCQS_";
            string Bucket = "project123";
            Mac mac = new(AccessKey, SccessKey);

            string saveKey = filename.FileName /*"project123_" + DateTime.Now.ToString("yyyyMMdd") + "_" + System.Guid.NewGuid().ToString().Substring(0, 6) + */;
            string localFile = @"C:\Users\LiuQing\Desktop\" + saveKey;
            //上传策略
            PutPolicy putPolicy = new PutPolicy();
            putPolicy.Scope = Bucket;
            //上传策略有效期
            putPolicy.SetExpires(3600);
            //上传后多久自动删除,不设置的话就不会删除
            putPolicy.DeleteAfterDays = 1;
            //生成上传凭证
            string jstr = putPolicy.ToJsonString();
            string token = Auth.CreateUploadToken(mac, jstr);
            Config config = new()
            {
                Zone = Zone.ZONE_CN_East,
                UseHttps = true,
                UseCdnDomains = true
            };
            using (System.IO.FileStream stream = System.IO.File.Create(localFile))
            {
                filename.CopyToAsync(stream);
                stream.Flush();
            }

            UploadManager um = new UploadManager(config);
            HttpResult result = um.UploadFile(localFile, saveKey, token, null);

            sb.Append(Newtonsoft.Json.JsonConvert.SerializeObject(result));

            return "";
        }
    }
}
