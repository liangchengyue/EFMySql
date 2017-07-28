$(function () {
    BUI.use(['bui/grid', 'bui/data'], function (Grid, Data) {
        var Store = Data.Store,
            columns = [
                { title: '表头1', dataIndex: 'a', width: 100 },
                { id: '123', title: '表头2', dataIndex: 'b', width: 100 },
                { title: '表头3', dataIndex: 'c', width: 200 }
            ];

        var store = new Store({
            url: 'Student/Index',
            autoLoad: true,
            pageSize: 3,
            proxy: {
                ajaxOptions: { //ajax的配置项，不要覆盖success,和error方法
                    traditional: true,
                    type: 'post'
                }
            },
            params: {
                a: ['a1', 'a2'],
                b: 'b1'
            },
            root: 'records',
            totalProperty: 'totalCount'
        }),
            grid = new Grid.Grid({
                render: '#grid',
                columns: columns,
                loadMask: true,
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