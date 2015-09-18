namespace MODERN_ART_ASSOCIATION_OF_KAOHSIUNG.Models.TableModel
{
    public class MeetingRecord
    {
        /// <summary>
        /// 資料表名稱
        /// </summary>
        public string TABLE_NAME { get { return "MeetingRecord"; } }
        
        /// <summary>
        /// 會議記錄日期
        /// </summary>
        public string MeetingRecord_Date { get; set; }

        /// <summary>
        /// 會議記錄詳細資料
        /// </summary>
        public string MeetingRecord_Detail { get; set; }

        /// <summary>
        /// 會議記錄結束時間
        /// </summary>
        public string MeetingRecord_Endtime { get; set; }

        /// <summary>
        /// 檔案路徑
        /// </summary>
        public string MeetingRecord_File { get; set; }

        /// <summary>
        /// 會議紀錄編號
        /// </summary>
        public string MeetingRecord_ID { get; set; }

        /// <summary>
        /// 修改時間
        /// </summary>
        public string MeetingRecord_Modificationdatetime { get; set; }

        /// <summary>
        /// 會議地點
        /// </summary>
        public string MeetingRecord_Place { get; set; }

        /// <summary>
        /// 會議記錄開始時間
        /// </summary>
        public string MeetingRecord_Starttime { get; set; }

        /// <summary>
        /// 會議紀錄標題
        /// </summary>
        public string MeetingRecord_Title { get; set; }

        public void PK_MeetingRecord(string MeetingRecord_ID)
        {

        }
    }
}