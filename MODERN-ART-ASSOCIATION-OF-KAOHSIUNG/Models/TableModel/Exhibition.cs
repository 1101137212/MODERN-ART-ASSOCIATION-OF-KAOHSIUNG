namespace MODERN_ART_ASSOCIATION_OF_KAOHSIUNG.Models.TableModel
{
    public class Exhibition
    {
        /// <summary>
        /// 資料表名稱
        /// </summary>
        public string TABLE_NAME { get { return "Exhibition"; } }
        
        /// <summary>
        /// 展覽詳細資料
        /// </summary>
        public string Exhibition_Detail { get; set; }

        /// <summary>
        /// 展覽結束時間
        /// </summary>
        public string Exhibition_Enddatetime { get; set; }

        /// <summary>
        /// 展覽編號
        /// </summary>
        public string Exhibition_ID { get; set; }

        /// <summary>
        /// 其他參展人
        /// </summary>
        public string Exhibition_Otherpeople { get; set; }

        /// <summary>
        /// 展覽圖片
        /// </summary>
        public string Exhibition_Picture { get; set; }

        /// <summary>
        /// 展覽地點
        /// </summary>
        public string Exhibition_Place { get; set; }

        /// <summary>
        /// 展覽開始時間
        /// </summary>
        public string Exhibition_Startdatetime { get; set; }

        /// <summary>
        /// 展覽標題
        /// </summary>
        public string Exhibition_Title { get; set; }

        public void PK_Exhibition(string Exhibition_ID)
        {

        }
    }
}