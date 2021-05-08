Vue.directive('select2', {
    bind(el, binding, vnode) {
        const event = new Event('change');
        const myevent = new Event('update');
        $(el).select2().on("select2:select", function (e) {
            //console.log(e.target.value);
            el.dispatchEvent(event);
            el.dispatchEvent(myevent);
        });

    }
});

var selectTest = new Vue({
    el: "#test",
    data: function () {
        return {
            selected: "",
            content: ""
        };
    },
    methods: {
        sayhello(arg) {
            console.log(`${arg} selected: ${this.selected}`);

        }
    },
    computed: {
        myobj: {
            get() {
                return this.selected;

            },
            set(value) {
                console.log(value);
                this.selected = value;
            }
        }
    },
     //mounted:function(){
     //    $("select").select2();
     //}

});
$("select").select2({});
//# sourceMappingURL=Select2Test.js.map