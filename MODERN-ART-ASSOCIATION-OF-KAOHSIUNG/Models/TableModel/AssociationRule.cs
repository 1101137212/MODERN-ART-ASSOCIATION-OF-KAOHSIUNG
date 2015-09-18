namespace MODERN_ART_ASSOCIATION_OF_KAOHSIUNG.Models.TableModel
{
    public class AssociationRule
    {
        /// <summary>
        /// 資料表名稱
        /// </summary>
        public string TABLE_NAME { get { return "AssociationRule"; } }
        
        /// <summary>
        /// 學會規章詳細資料
        /// </summary>
        public string AssociationRule_Detail { get; set; }

        /// <summary>
        /// 學會規章編號
        /// </summary>
        public string AssociationRule_ID { get; set; }

        /// <summary>
        /// 修改時間
        /// </summary>
        public string AssociationRule_Modificationdatetime { get; set; }

        /// <summary>
        /// 修改人
        /// </summary>
        public string AssociationRule_Modifier { get; set; }

        /// <summary>
        /// 學會規章標題
        /// </summary>
        public string AssociationRule_Title { get; set; }

        public void PK_AssociationRule(string AssociationRule_ID)
        {

        }
    }
}