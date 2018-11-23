using Microsoft.VisualStudio.TestTools.UnitTesting;
using RaeClass.Helper;
using RaeClass.Models;
using System;
using System.Security.Cryptography;
using System.Text;

namespace UnitTestProject_Rae
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestCreateJson()
        {
            Read read = new Read();
            read._id = "W92eXqu9e31Z7Ks-";
            read._openid = "oT_iO4tBijzyXT91iOW6wmGF801Q";
            read.fcreateBy = "choc";
            read.fcreateTime = DateTime.Now.ToString();
            read.fdocStatus = "A";
            read.flevel = "1";
            read.fcnContent = "<p style=\"text - align:left; line - height:150 % \">         < span style = \"font-family:����;color:black;background:yellow;background:yellow\" > �Զ�����Ӧ�յ�����������Ϊ��ʱ�ظ�ִ�У�������ÿ������ </ span >< span style = \"color:black;background:yellow;background:yellow\" > 12 </ span >< span style = \"font-family:����;color:black;background:yellow;background:yellow\" > ��ִ��һ�Ρ���ִ��ʱ��������ݿ���δ����Ӧ�յ������ݣ�</ span >                         </ p > <p style=\"margin - left:24px; text - align:left; line - height:150 % \">            < span style = \";color:black;background:yellow;background:yellow\" > 1.< span style = \"font:9px &#39;Times New Roman&#39;\" > &nbsp; &nbsp; &nbsp; &nbsp; </ span ></ span >< span style = \"font-family:����;color:black;background:yellow;background:yellow\" > �ò�������û�ж�Ӧ��ͬ�ţ�����ݲ�ͬ�ͻ����ɶ�Ӧ��Ӧ�յ���ÿ���ͻ�һ�ţ�����в��ּ�¼�Ҳ���Ĭ�ϼ�Ŀ����ü�¼��Ӧ�Ŀͻ����µ����� </ span >< span style = \"font-family:����;color:black;background:red;background:red\" > û�����۶��������� </ span >< span style = \"font-family:����;color:black;background:yellow;background:yellow\" > ��������Ӧ�յ���ͬʱӦ���б�����Ϣ�����û���</ span >                                              </ p > ";
            read.fenContent = "<p style=\"text - align:left; line - height:150 % \">         < span style = \"font-family:����;color:black;background:yellow;background:yellow\" > �Զ�����Ӧ�յ�����������Ϊ��ʱ�ظ�ִ�У�������ÿ������ </ span >< span style = \"color:black;background:yellow;background:yellow\" > 12 </ span >< span style = \"font-family:����;color:black;background:yellow;background:yellow\" > ��ִ��һ�Ρ���ִ��ʱ��������ݿ���δ����Ӧ�յ������ݣ�</ span >                         </ p > ";
            read.frecordFileId1 = "cloud://reaclass-dev-b66f08.7265-reaclass-dev-b66f08/read/xty.mp3";
            read.frecordFileId2 = "cloud://reaclass-dev-b66f08.7265-reaclass-dev-b66f08/read/xty.mp3";
            read.fnumber = "read1201811030001";
            read.fname = "TT";
            read.fmodifyBy = "choc";
            read.fmodifyTime = DateTime.Now.ToString();
            string json = JsonHelper.SerializeObject(read);

        }

        [TestMethod]
        public void TestSqliteConn()
        {

        }

        [TestMethod]
        public void TestGetDateTimeSerial()
        {
            //������ˮ��20180909
            var dt = DateTime.Now;
            StringBuilder sb = new StringBuilder();
            sb.Append(dt.Year.ToString());
            sb.Append(dt.Month>10?dt.Month.ToString():"0" + dt.Month);
            sb.Append(dt.Day>10?dt.Month.ToString():"0" + dt.Day);
            byte[] randomBytes = new byte[4];
            RNGCryptoServiceProvider rngServiceProvider = new RNGCryptoServiceProvider();
            rngServiceProvider.GetBytes(randomBytes);
            int result = BitConverter.ToInt32(randomBytes, 0);
        }

        [TestMethod]
        public void TestGetDateTimeFormat()
        {
            //������ˮ��20180909
            var dt = DateTime.Now;
            string str = dt.ToString("yyyy-MM-dd");
        }


    }
}
