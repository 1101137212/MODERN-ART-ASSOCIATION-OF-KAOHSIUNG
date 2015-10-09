
$(document).ready(function () {
    /// <summary>
    /// 學會大事跡(AE)
    /// </summary>
    /// <history>
    /// 2015/10/09   George Liu   Create
    /// </history>

    //#region 設定Control

    $.ajax({
        url: '/AA/GetAssociationEventListData',
        type: 'POST',
        dataType: 'json',
        success: function (data) {
            console.log(data);
        },
        error: function () {
            console.log("無法取得db");
        }
    });

    //#endregion
 
    //#region 設定UI   

    //#endregion

    //#region 設定Event

    //#endregion

    //#region Private Method


    //#endregion
});