<template>
    <div id='about' class="tab-pane  fade in  active">
        <div class="body-content">

            <router-view />
            <!-- Start About your self section-->
            <div class="row">
                <div class="col-md-3 text-center">
                    <img src="/images/me.jpg" alt="avatar" class="img-responsive img-profile img-circle">
                </div>
                <div class="col-md-9">
                    <div class="mini-desc">
                        <h2 class="title">{{introductionHeader}}</h2>

                        <p>{{introductionBody}}</p>
                    </div>
                </div>
            </div>
            <!-- End About your self section-->
            <!-- Start List Indentity and services your self  section-->
            <div class="row">
                <div class="col-md-6">
                    <h3 class="title with-icon"><i class="fa fa-credit-card icn-title"></i> Indentity</h3>
                    <div class="identity-area">
                        <div class="row" v-for="identity in identities">
                            <div class="col-sm-4"><label>{{identity.header}}</label></div>
                            <div class="col-sm-8">{{identity.value}}</div>
                        </div>
                    </div>
                </div>

                <div class="col-md-6">
                    <h3 class="title with-icon"><i class="fa fa-comments-o icn-title"></i> Amazing Quotes</h3>
                    <div class="box-block">
                        <div id='testimonial-slider' class="carousel slide" data-ride="carousel" data-interval="false">
                            <div class="carousel-inner">
                                <div class="item active" v-for="quote in quotes">
                                    <div class="box-testimonial">
                                        <div class="oComment">
                                            <p>{{quote.value}}</p>
                                        </div>
                                        <img src="/images/me.jpg" alt=''>
                                    </div>
                                </div>
                            </div>
                            <div class="control-testi-slider">
                                <a href="#testimonial-slider" data-slide="prev"><i class="fa fa-chevron-left"></i></a>
                                <a href="#testimonial-slider" data-slide="next"><i class="fa fa-chevron-right"></i></a>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div><!--End About tab content section-->
</template>

<script>
    export default {
        name: 'Home',
        data() {
            return {
                identities: [],
                introductionBody: "",
                introductionHeader: "",
                quotes: []
            }
        },
        mounted() {
            var self = this;

            this.$http.get("http://localhost:50823/api/content/home").then((response) => {
                self.identities = response.data.identity;
                self.introductionHeader = response.data.introductionHeader;
                self.introductionBody = response.data.introductionBody;
                self.quotes = response.data.quotes;

                console.log(response);
            });
        },
        props: {
            msg: "Homemmmmme"
        }
    };
</script>

<!-- Add "scoped" attribute to limit CSS to this component only -->
<style scoped>
</style>