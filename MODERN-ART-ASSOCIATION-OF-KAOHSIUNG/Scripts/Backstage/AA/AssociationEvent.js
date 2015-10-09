$(function () {
    ///<summary>
    ///學會大事跡(AE)
    ///</summary>
    ///<history>
    ///2015/10/09   George Liu   Create
    ///</history>

    //#region 設定Control

    $.ajax({
        url: '/BAA/GetAssociationEventdata_B',
        type: 'POST',
        dataType: 'json',
        success: function (data) {
            console.log(data);
        },
        error: function () {
            console.log("無法取得db");
        }
    });
    $.ajax({
        url: '/BAA/CreateAssociationEventdata_B',
        type: 'POST',
        data: {
            AssociationEvent_Title: 'test8887',
            AssociationEvent_Detail: 'test8887',
            AssociationEvent_Date: '2015/08/30',
            AssociationEvent_Picture: 'test8854511111',
            AssociationEvent_Modifier: 6,
            AssociationEvent_Modificationdatetime: '2015/08/28'
        },
        success: function (data) {
            console.log("test");
        },
        error: function () {
            console.log("無法取得db");
        }
    });
    //$.ajax({
    //    url: '/BAA/UpdateAssociationEventdata_B',
    //    type: 'POST',
    //    data: {
    //        AssociationEvent_Title: 'test123',
    //        AssociationEvent_Detail: 'test234',
    //        AssociationEvent_Date: '2015/08/27',
    //        AssociationEvent_Picture: 'test',
    //        AssociationEvent_Modifier: 4,
    //        AssociationEvent_Modificationdatetime:'2015/08/27',
    //        AssociationEvent_ID: 21
    //    },
    //    dataType: 'json',
    //    success: function (data) {
    //        console.log("test");
    //    },
    //    error: function () {
    //        console.log("無法取得db");
    //    }
    //});
    //$.ajax({
    //    url: '/BAA/DeleteAssociationEventdata_B',
    //    type: 'POST',
    //    data: {
    //        AssociationEvent_ID: 13
    //    },
    //    dataType: 'json',
    //    success: function (data) {
    //        console.log("test");
    //    },
    //    error: function () {
    //        console.log("無法取得db");
    //    }
    //});

    //#endregion

    //#region 設定UI   

    //#endregion

    //#region 設定Event

    //#endregion

    //#region Private Method


    //#endregion
});

