$(function () {
    ///<summary>
    ///作品集(AWS)
    ///</summary>
    ///<history>
    ///2015/10/09   George Liu   Create
    ///</history>

    //#region 設定Control

    $.ajax({
        url: '/AWS/GetArtisticworksdata',
        type: 'POST',
        dataType: 'json',
        data: {
            Member_ID: 4
        },
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
