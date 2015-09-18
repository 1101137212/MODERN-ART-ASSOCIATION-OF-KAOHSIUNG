namespace MODERN_ART_ASSOCIATION_OF_KAOHSIUNG.Models.TableModel
{
    public class AssociationHistory
    {
        /// <summary>
        /// 資料表名稱
        /// </summary>
        public string TABLE_NAME { get { return "AssociationHistory"; } }
        
        /// <summary>
        /// 學會沿革詳細資料
        /// </summary>
        public string AssociationHistory_Detail { get; set; }

        /// <summary>
        /// 學會沿革詳細資料2
        /// </summary>
        public string AssociationHistory_Detail2 { get; set; }

        /// <summary>
        /// 學會沿革詳細資料3
        /// </summary>
        public string AssociationHistory_Detail3 { get; set; }

        /// <summary>
        /// 學會沿革編號
        /// </summary>
        public string AssociationHistory_ID { get; set; }

        /// <summary>
        /// 修改時間
        /// </summary>
        public string AssociationHistory_Modificationdatetime { get; set; }

        /// <summary>
        /// 修改人編號
        /// </summary>
        public string AssociationHistory_Modifier { get; set; }

        public void PK_AssociationHistory(string AssociationHistory_ID)
        {

        }
    }
}