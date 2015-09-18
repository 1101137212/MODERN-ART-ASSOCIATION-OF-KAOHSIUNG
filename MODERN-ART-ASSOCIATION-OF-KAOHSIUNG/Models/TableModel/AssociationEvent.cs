namespace MODERN_ART_ASSOCIATION_OF_KAOHSIUNG.Models.TableModel
{
    public class AssociationEvent
    {
        /// <summary>
        /// 資料表名稱
        /// </summary>
        public string TABLE_NAME { get { return "AssociationEvent"; } }
        
        /// <summary>
        /// 學會事蹟時間
        /// </summary>
        public string AssociationEvent_Date { get; set; }

        /// <summary>
        /// 學會事蹟詳細資料
        /// </summary>
        public string AssociationEvent_Detail { get; set; }

        /// <summary>
        /// 學會事蹟編號
        /// </summary>
        public string AssociationEvent_ID { get; set; }

        /// <summary>
        /// 修改時間
        /// </summary>
        public string AssociationEvent_Modificationdatetime { get; set; }

        /// <summary>
        /// 修改人
        /// </summary>
        public string AssociationEvent_Modifier { get; set; }

        /// <summary>
        /// 學會事蹟照片
        /// </summary>
        public string AssociationEvent_Picture { get; set; }

        /// <summary>
        /// 學會事蹟標題
        /// </summary>
        public string AssociationEvent_Title { get; set; }

        public void PK_AssociationEvent(string AssociationEvent_ID)
        {

        }
    }
}