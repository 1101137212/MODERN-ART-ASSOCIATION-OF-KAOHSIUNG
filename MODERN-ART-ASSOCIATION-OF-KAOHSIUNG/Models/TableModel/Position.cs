namespace MODERN_ART_ASSOCIATION_OF_KAOHSIUNG.Models.TableModel
{
    public class Position
    {
        /// <summary>
        /// 資料表名稱
        /// </summary>
        public string TABLE_NAME { get { return "Position"; } }
        
        /// <summary>
        /// 職位權限
        /// </summary>
        public string Position_Competence { get; set; }

        /// <summary>
        /// 職位編號
        /// </summary>
        public string Position_ID { get; set; }

        /// <summary>
        /// 職位名稱
        /// </summary>
        public string Position_Name { get; set; }

        public void PK_Position(string Position_ID)
        {

        }
    }
}