﻿namespace MODERN_ART_ASSOCIATION_OF_KAOHSIUNG.Models.TableModel
{
    public class ResearchField
    {
        /// <summary>
        /// 資料表名稱
        /// </summary>
        public string TABLE_NAME { get { return "ResearchField"; } }
        
        /// <summary>
        /// 研究領域編號
        /// </summary>
        public string ResearchField_ID { get; set; }

        /// <summary>
        /// 研究領域名稱
        /// </summary>
        public string ResearchField_Name { get; set; }

        public void PK_ResearchField(string ResearchField_ID)
        {

        }
    }
}