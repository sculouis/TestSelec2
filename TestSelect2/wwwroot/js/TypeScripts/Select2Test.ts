Vue.directive('select2', {
    inserted(el, binding) {
            $(el).select2();
    },
    bind(el, binding, vnode) {
        const event = new Event('change');
        const updateEvent = new Event('update');
        $(el).select2().on("select2:select", function (e) {
            //console.log(e.target.value);
            el.dispatchEvent(event);
            el.dispatchEvent(updateEvent);
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
});