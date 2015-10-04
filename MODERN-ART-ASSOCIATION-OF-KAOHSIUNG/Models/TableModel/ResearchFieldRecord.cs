namespace MODERN_ART_ASSOCIATION_OF_KAOHSIUNG.Models.TableModel
{
    public class ResearchFieldRecord
    {
        /// <summary>
        /// 資料表名稱
        /// </summary>
        public string TABLE_NAME { get { return "ResearchFieldRecord"; } }
        
        /// <summary>
        /// 會員編號
        /// </summary>
        public string Member_ID { get; set; }

        /// <summary>
        /// 研究領域編號
        /// </summary>
        public string ResearchField_ID { get; set; }

        /// <summary>
        /// 研究領域時間
        /// </summary>
        public string ResearchFieldRecord_Date { get; set; }

        /// <summary>
        /// 研究領域紀錄編號
        /// </summary>
        public string ResearchFieldRecord_ID { get; set; }

        public void PK_ResearchFieldRecord(string ResearchFieldRecord_ID)
        {

        }
    }
}