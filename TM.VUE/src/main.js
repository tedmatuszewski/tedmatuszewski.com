import Vue from 'vue';
import App from './App.vue';
import Router from 'vue-router';
import axios from 'axios';
import VueAxios from 'vue-axios';
import VueToast from 'vue-toast-notification';
import 'vue-toast-notification/dist/index.css';
import HomeComponent from "./components/HomeComponent.vue";
import ContactComponent from "./components/ContactComponent.vue";
import AboutComponent from "./components/AboutComponent.vue";
import SnakeComponent from "./components/SnakeComponent.vue";
import ManageComponent from "./components/ManageComponent.vue";
import { ClientTable } from 'vue-tables-2';
import config from "./config.json";
import GlobalEvents from 'vue-global-events';

Vue.config.productionTip = true;

axios.defaults.baseURL = config.api_url;

Vue.use(VueToast);
Vue.use(VueAxios, axios);
Vue.use(Router);
Vue.use(ClientTable);

Vue.component('GlobalEvents', GlobalEvents)

let router = new Router({
    base: __dirname,
    linkExactActiveClass: "active",
    routes: [
        {
            path: '/',
            name: "home",
            component: HomeComponent
        },
        {
            path: "/contact",
            name: "contact",
            component: ContactComponent
        },
        {
            path: "/about",
            name: "about",
            component: AboutComponent
        },
        {
            path: "/snake",
            name: "snake",
            component: SnakeComponent
        },
        {
            path: "/manage",
            name: "manage",
            component: ManageComponent
        }
    ]
});

new Vue({
    router: router,
    render: h => h(App)
}).$mount('#app');
