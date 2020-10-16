using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Windows.Forms;

namespace JsonTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //이벤트 선언
            InitEvent();
        }

        /// <summary>
        /// 이벤트 선언 메서드
        /// </summary>
        private void InitEvent()
        {
            uiBtn_CreateJson.Click += UiBtn_CreateJson_Click;
            uiBtn_WriteJson.Click += UiBtn_WriteJson_Click;
            uiBtn_ReadJson.Click += UiBtn_ReadJson_Click;
        }

        /// <summary>
        /// JSON Read 버튼 클릭 이벤트 핸들러
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UiBtn_ReadJson_Click(object sender, EventArgs e)
        {
            uiRtb_Text.Clear();
            ReadJson();
        }

        /// <summary>
        /// JSON Write 버튼 클릭 이벤트 핸들러
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UiBtn_WriteJson_Click(object sender, EventArgs e)
        {
            uiRtb_Text.Clear();
            WrtieJson();
        }

        /// <summary>
        /// JSON Create 버튼 클릭 이벤트 핸들러
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UiBtn_CreateJson_Click(object sender, EventArgs e)
        {
            CreateJson();
        }

        /// <summary>
        /// JSON 파일 생성 메서드
        /// </summary>
        private void CreateJson()
        {
            string path = @"C:\test\test.json";

            if (!File.Exists(path))
            {
                using (File.Create(path))
                {
                    MessageBox.Show("파일 생성 성공");
                }
            }
            else
            {
                MessageBox.Show("이미 파일이 존재 합니다.");
            }
        }

        /// <summary>
        /// JSON 파일 쓰기 메서드
        /// </summary>
        private void WrtieJson()
        {
            string path = @"C:\test\test.json";

            //json 파일이 존재 한다면
            if (File.Exists(path))
            {
                InputJson(path);
            }
        }

        /// <summary>
        /// Json 내용 입력
        /// </summary>
        private void InputJson(string path)
        {
            //사용자 정보 배열로 선언
            var users = new[] { "USER1", "USER2", "USER3", "USER4" };
            
            JObject dbSpec = new JObject(
                new JProperty("IP", "127.0.0.1"),
                new JProperty("ID", "BEOMBEOMJOJO"),
                new JProperty("PW", "1234"),
                new JProperty("SID", "TEST"),
                new JProperty("DATABASE", "TEST")
                );

            //Jarray 로 추가
            dbSpec.Add("USERS", JArray.FromObject(users));

            File.WriteAllText(path, dbSpec.ToString());

            //텍스트 박스에 출력
            uiRtb_Text.Text = dbSpec.ToString();
        }

        /// <summary>
        /// JSON 파일 내용 추출 및 읽어오는 메서드
        /// </summary>
        private void ReadJson()
        {
            string jsonFilePath = @"C:\test\test.json";
            string str = string.Empty;
            string users = string.Empty;

            //// Json 파일 읽기
            using (StreamReader file = File.OpenText(jsonFilePath))
            using (JsonTextReader reader = new JsonTextReader(file))
            {
                JObject json = (JObject)JToken.ReadFrom(reader);

                DataBase _db = new DataBase();

                _db.IP = (string)json["IP"].ToString();
                _db.ID = (string)json["ID"].ToString();
                _db.PW = (string)json["PW"].ToString();
                _db.SID = (string)json["SID"].ToString();
                _db.DATABASE = (string)json["DATABASE"].ToString();

                var user = json.SelectToken("USERS");
                var cnt = user.Count();

                for(int idx = 0; idx < user.Count(); idx++)
                {
                    var name = user[idx].ToString();

                    if(idx == 0)
                    {
                        users += $"{name}";
                    }
                    else
                    {
                        users += $" , {name}";
                    }
                }

                str = $" IP : {_db.IP}\n ID : {_db.ID}\n PW : {_db.PW}\n SID :" +
                    $" {_db.SID}\n DATABASE : {_db.DATABASE}\n USERS : {users}";
                uiRtb_Text.Text = str;
            }
        }
    }

    public class DataBase
    {
        public string IP = string.Empty;
        public string ID = string.Empty;
        public string PW = string.Empty;
        public string SID = string.Empty;
        public string DATABASE = string.Empty;
    }
}
