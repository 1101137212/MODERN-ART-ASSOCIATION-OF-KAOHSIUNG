namespace MODERN_ART_ASSOCIATION_OF_KAOHSIUNG.Models.TableModel
{
    public class LatestNews
    {
        /// <summary>
        /// 資料表名稱
        /// </summary>
        public string TABLE_NAME { get { return "LatestNews"; } }

        /// <summary>
        /// 最新消息編號
        /// </summary>
        public string LatestNews_ID { get; set; }

        /// <summary>
        /// 最新消息標題
        /// </summary>
        public string LatestNews_Title { get; set; }

        /// <summary>
        /// 最新消息詳細資料
        /// </summary>
        public string LatestNews_Detail { get; set; }

        /// <summary>
        /// 消息結束時間
        /// </summary>
        public string LatestNews_Enddatetime { get; set; }

        /// <summary>
        /// 修改時間
        /// </summary>
        public string LatestNews_Modificationdatetime { get; set; }

        /// <summary>
        /// 修改人
        /// </summary>
        public string LatestNews_Modifier { get; set; }

        /// <summary>
        /// 主辦單位
        /// </summary>
        public string LatestNews_Organizer { get; set; }

        /// <summary>
        /// 主辦單位電話
        /// </summary>
        public string LatestNews_Organizertelephone { get; set; }

        /// <summary>
        /// 主辦單位電話區碼
        /// </summary>
        public string LatestNews_Organizertelephonearea { get; set; }

        /// <summary>
        /// 主辦單位電話分機
        /// </summary>
        public string LatestNews_Organizertelephoneext { get; set; }

        /// <summary>
        /// 活動OR展覽地點
        /// </summary>
        public string LatestNews_Place { get; set; }

        /// <summary>
        /// 新聞聯絡人
        /// </summary>
        public string LatestNews_Presscontacts { get; set; }

        /// <summary>
        /// 新聞聯絡人電子郵件
        /// </summary>
        public string LatestNews_Presscontactsemail { get; set; }

        /// <summary>
        /// 新聞聯絡人手機
        /// </summary>
        public string LatestNews_Presscontactsmobile { get; set; }

        /// <summary>
        /// 新聞聯絡人電話
        /// </summary>
        public string LatestNews_Presscontactstelephone { get; set; }

        /// <summary>
        /// 新聞聯絡人電話區碼
        /// </summary>
        public string LatestNews_Presscontactstelephonearea { get; set; }

        /// <summary>
        /// 新聞聯絡人電話分機
        /// </summary>
        public string LatestNews_Presscontactstelephoneext { get; set; }

        /// <summary>
        /// 消息開始時間
        /// </summary>
        public string LatestNews_Startdatetime { get; set; }

        /// <summary>
        /// 最新消息分類
        /// </summary>
        public string LatestNews_State { get; set; }

        public void PK_LatestNews(string LatestNews_ID)
        {

        }
    }
}