namespace MODERN_ART_ASSOCIATION_OF_KAOHSIUNG.Models.TableModel
{
    public class Artisticworks
    {
        /// <summary>
        /// 資料表名稱
        /// </summary>
        public string TABLE_NAME { get { return "Artisticworks"; } }
        
        /// <summary>
        /// 作品日期
        /// </summary>
        public string Artisticworks_Date { get; set; }

        /// <summary>
        /// 作品編號
        /// </summary>
        public string Artisticworks_ID { get; set; }

        /// <summary>
        /// 作品名稱
        /// </summary>
        public string Artisticworks_Name { get; set; }

        /// <summary>
        /// 作品
        /// </summary>
        public string Artisticworks_Picture { get; set; }

        /// <summary>
        /// 會員編號
        /// </summary>
        public string Member_ID { get; set; }

        public void PK_Artisticworks(string Artisticworks_ID)
        {

        }
    }
}