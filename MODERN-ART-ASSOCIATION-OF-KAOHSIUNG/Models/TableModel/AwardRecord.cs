namespace MODERN_ART_ASSOCIATION_OF_KAOHSIUNG.Models.TableModel
{
    public class AwardRecord
    {
        /// <summary>
        /// 資料表名稱
        /// </summary>
        public string TABLE_NAME { get { return "AwardRecord"; } }
        
        /// <summary>
        /// 獎項編號
        /// </summary>
        public string Award_ID { get; set; }

        /// <summary>
        /// 獎項紀錄時間
        /// </summary>
        public string AwardRecord_Date { get; set; }

        /// <summary>
        /// 獎項紀錄編號
        /// </summary>
        public string AwardRecord_ID { get; set; }

        /// <summary>
        /// 會員編號
        /// </summary>
        public string Member_ID { get; set; }

        public void PK_AwardRecord(string AwardRecord_ID)
        {

        }
    }
}