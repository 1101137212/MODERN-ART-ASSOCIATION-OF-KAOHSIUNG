﻿namespace MODERN_ART_ASSOCIATION_OF_KAOHSIUNG.Models.TableModel
{
    public class ExhibitionRecord
    {
        /// <summary>
        /// 資料表名稱
        /// </summary>
        public string TABLE_NAME { get { return "ExhibitionRecord"; } }
        
        /// <summary>
        /// 展覽編號
        /// </summary>
        public string Exhibition_ID { get; set; }

        /// <summary>
        /// 參展紀錄編號
        /// </summary>
        public string ExhibitionRecord_ID { get; set; }

        /// <summary>
        /// 參展身分
        /// </summary>
        public string ExhibitionRecord_State { get; set; }

        /// <summary>
        /// 會員編號
        /// </summary>
        public string Member_ID { get; set; }

        public void PK_ExhibitionRecord(string ExhibitionRecord_ID)
        {

        }
    }
}