﻿using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RaeClass;
using RaeClass.Models;
using RaeClass.Repository;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject_Rae
{
    [TestClass]
    public class ReadRepositoryTest
    {

        HttpClient client;

        [TestInitialize]
        public void Init()
        {
            var builder = new WebHostBuilder()
                .UseContentRoot(Directory.GetCurrentDirectory())
                .UseStartup<Startup>()
                .UseEnvironment("Development");
            var server = new TestServer(builder);
            var client = server.CreateClient();
            // client always expects json results
            client.DefaultRequestHeaders.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        [TestMethod]
        public async Task AddAsyncTest()
        {
            var response = await client.GetAsync($"api/Read/GetReadList");
            
        }

        public Read GetReadData()
        {
            Read read = new Read();
            read._id = "W92eXqu9e31Z7Ks-";
            read._openid = "oT_iO4tBijzyXT91iOW6wmGF801Q";
            read.fcreateBy = "choc";
            read.fcreateTime = DateTime.Now.ToString();
            read.fdocStatus = "A";
            read.flevel = "1";
            read.fcnContent = "<p style=\"text - align:left; line - height:150 % \">         < span style = \"font-family:宋体;color:black;background:yellow;background:yellow\" > 自动生成应收单的任务设置为定时重复执行，如设置每天晚上 </ span >< span style = \"color:black;background:yellow;background:yellow\" > 12 </ span >< span style = \"font-family:宋体;color:black;background:yellow;background:yellow\" > 点执行一次。在执行时，检查数据库中未生成应收单的数据：</ span >                         </ p > <p style=\"margin - left:24px; text - align:left; line - height:150 % \">            < span style = \";color:black;background:yellow;background:yellow\" > 1.< span style = \"font:9px &#39;Times New Roman&#39;\" > &nbsp; &nbsp; &nbsp; &nbsp; </ span ></ span >< span style = \"font-family:宋体;color:black;background:yellow;background:yellow\" > 该部分数据没有对应合同号，则根据不同客户生成对应的应收单，每个客户一张；如果有部分记录找不到默认价目表，则该记录对应的客户名下的所有 </ span >< span style = \"font-family:宋体;color:black;background:red;background:red\" > 没有销售订单的数据 </ span >< span style = \"font-family:宋体;color:black;background:yellow;background:yellow\" > 都不生成应收单，同时应该有报错信息给到用户。</ span >                                              </ p > ";
            read.fenContent = "<p style=\"text - align:left; line - height:150 % \">         < span style = \"font-family:宋体;color:black;background:yellow;background:yellow\" > 自动生成应收单的任务设置为定时重复执行，如设置每天晚上 </ span >< span style = \"color:black;background:yellow;background:yellow\" > 12 </ span >< span style = \"font-family:宋体;color:black;background:yellow;background:yellow\" > 点执行一次。在执行时，检查数据库中未生成应收单的数据：</ span >                         </ p > ";
            read.frecordFileId1 = "cloud://reaclass-dev-b66f08.7265-reaclass-dev-b66f08/read/xty.mp3";
            read.frecordFileId2 = "cloud://reaclass-dev-b66f08.7265-reaclass-dev-b66f08/read/xty.mp3";
            read.fnumber = "read1201811030001";
            read.fname = "TT";
            read.fmodifyBy = "choc";
            read.fmodifyTime = DateTime.Now.ToString();
            //string json = JsonHelper.SerializeObject(read);
            return read;
        }



    }
}
