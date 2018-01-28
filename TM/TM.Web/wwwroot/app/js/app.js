var app = new Vue({
    el: '#app',
    data: {
        todos: {}
    },
    methods: {
        create: function (event) {
            this.todos.data.push({ title: "title dd", text: "value33" });
        },
        remove: function (item, event) {
            var index = this.todos.data.indexOf(item);

            this.todos.data.splice(index, 1);
        }
    },
    mounted: function () {
        var self = this;

        this.$nextTick(function () {
            fetch('/api/values').then(function (response) {
                return response.json();
            }).then(function (json) {
                self.todos = json;
            });
        });
    }
})