<template>
    <div id='about' class="tab-pane  fade in  active">
        <div class="body-content">
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
            <div class="row">
                <div class="col-md-6">
                    <h3 class="title with-icon"><i class="fa fa-credit-card icn-title"></i> Identity</h3>
                    <div class="identity-area">
                        <div class="row" v-for="identity in identities" :key="identity.id">
                            <div class="col-sm-4"><label>{{identity.Header}}</label></div>
                            <div class="col-sm-8">{{identity.Value}}</div>
                        </div>
                    </div>
                </div>

                <div class="col-md-6">
                    <h3 class="title with-icon"><i class="fa fa-comments-o icn-title"></i> Amazing Quotes</h3>
                    <div class="box-block">
                        <div id='testimonial-slider' class="carousel slide" data-ride="carousel" data-interval="false">
                            <div class="carousel-inner">
                                <div class="item" v-for="(quote, index) in quotes" :key="quote.id" v-bind:class="{ active: index == activeQuote }">
                                    <div class="box-testimonial">
                                        <div class="oComment">
                                            <p>{{quote.Value}}</p>
                                        </div>
                                        <img src="/images/me.jpg" alt=''>
                                    </div>
                                </div>
                            </div>
                            <div class="control-testi-slider">
                                <a href="#testimonial-slider" v-on:click.prevent="prevSlide"><i class="fa fa-chevron-left"></i></a>
                                <a href="#testimonial-slider" v-on:click.prevent="nextSlide"><i class="fa fa-chevron-right"></i></a>
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
                quotes: [],
                activeQuote: 0
            }
        },
        mounted() {
            var self = this;

            this.$http.get("/content/home").then((response) => {
                self.identities = response.data.Identity;
                self.introductionHeader = response.data.IntroductionHeader;
                self.introductionBody = response.data.IntroductionBody;
                self.quotes = response.data.Quotes;
            });
        },
        methods: {
            prevSlide: function () {
                var self = this;
                var last = self.quotes.length - 1;

                if (self.activeQuote == 0) {
                    self.activeQuote = last;

                    return;
                }

                self.activeQuote -= 1;
            },
            nextSlide: function() {
                var self = this;
                var last = self.quotes.length - 1;
                
                if (self.activeQuote == last) {
                    self.activeQuote = 0;

                    return;
                }

                self.activeQuote += 1;
            }
        },
        props: {
            msg: "Homemmmmme"
        }
    };
</script>

<!-- Add "scoped" attribute to limit CSS to this component only -->
<style scoped>
</style>