$(function () {
    BUI.use(['bui/grid', 'bui/data'], function (Grid, Data) {
        var Store = Data.Store,
            columns = [
                {
                    title: '学号',
                    dataIndex: 'No'
                },
                {
                    title: '姓名',
                    dataIndex: 'Name'
                },
                {
                    title: '性别',
                    dataIndex: 'Gender'
                },
                {
                    title: '操作',
                    renderer: (value,obj)=>{ console.log(obj.No); }
                }
            ];

        var store = new Store({
            url: 'GetList',
            proxy: {
                method: 'post',
                //dataType : 'jsonp', //返回数据的类型
                limitParam: 'pageSize', //一页多少条记录
                pageIndexParam: 'pageNum', //页码
                startParam: 'startNum' //起始记录
            },
            autoLoad: true,
            pageSize: 1 // 配置分页数目
        }),
            grid = new Grid.Grid({
                render: '#grid',
                columns: columns,
                loadMask: true,
                forceFit: true,	// 列宽按百分比自适应
                store: store,
                // 底部工具栏
                bbar: {
                    // pagingBar:表明包含分页栏
                    pagingBar: true
                }
            });

        grid.render();
    });
});