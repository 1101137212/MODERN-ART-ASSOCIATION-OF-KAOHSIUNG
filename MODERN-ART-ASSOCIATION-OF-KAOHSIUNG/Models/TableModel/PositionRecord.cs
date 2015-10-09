namespace MODERN_ART_ASSOCIATION_OF_KAOHSIUNG.Models.TableModel
{
    public class PositionRecord
    {
        /// <summary>
        /// 資料表名稱
        /// </summary>
        public string TABLE_NAME { get { return "PositionRecord"; } }
        
        /// <summary>
        /// 職位記錄編號
        /// </summary>
        public string PositionRecord_ID { get; set; }

        /// <summary>
        /// 會員編號
        /// </summary>
        public string Member_ID { get; set; }

        /// <summary>
        /// 職位編號
        /// </summary>
        public string Position_ID { get; set; }

        /// <summary>
        /// 職位結束時間
        /// </summary>
        public string PositionRecord_Enddate { get; set; }

        /// <summary>
        /// 職位開始時間
        /// </summary>
        public string PositionRecord_Startdate { get; set; }

        public void PK_PositionRecord(string PositionRecord_ID)
        {

        }
    }
}