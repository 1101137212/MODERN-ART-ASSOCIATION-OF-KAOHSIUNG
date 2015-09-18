namespace MODERN_ART_ASSOCIATION_OF_KAOHSIUNG.Models.TableModel
{
    public class Award
    {
        /// <summary>
        /// 資料表名稱
        /// </summary>
        public string TABLE_NAME { get { return "Award"; } }
        
        /// <summary>
        /// 獎項詳細內容
        /// </summary>
        public string Award_Detail { get; set; }

        /// <summary>
        /// 獎項編號
        /// </summary>
        public string Award_ID { get; set; }

        /// <summary>
        /// 獎項照片
        /// </summary>
        public string Award_Picture { get; set; }

        /// <summary>
        /// 獎項標題
        /// </summary>
        public string Award_Title { get; set; }

        public void PK_Award(string Award_ID)
        {

        }
    }
}