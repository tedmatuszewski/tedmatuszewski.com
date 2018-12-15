import Vue from 'vue';
import App from './App.vue';
import Router from 'vue-router';
import VueAxios from 'vue-axios';
import HomeComponent from "./components/HomeComponent.vue";
import ContactComponent from "./components/ContactComponent.vue";
import AboutComponent from "./components/AboutComponent.vue";

Vue.config.productionTip = true;

Vue.use(VueAxios);
Vue.use(Router);

let router = new Router({
    mode: 'history',
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
        }
    ]
});

new Vue({
    router: router,
    render: h => h(App)
}).$mount('#app');
