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
                        <h2 class="title">Hello, my name is Ted Matuszewski!</h2>

                        <p>I am currently a Web Developer for Nexteer Automotive; a part manufacturer with a focus on steering and halfshaft components. In this role I develop applications to support our manufacturing and validation processes.<p>

                        <p>Before joining Nexteer, I worked for DICE Corporation and was fortunate enough to work with amazing clients such as Ackerman Security, EPS Security, and SSD Systems.</p>

                        <p>In building upon my professional career I have always looked for freelancing opportunities to further expand my knowledge base. If you are interested in dicussing any freelance oppurtunities the best way to contact me is through my email or contact form on this website.</p>

                        <p>I am truly passionate about my work and always eager to connect with other web developers, so feel free to contact me if you would like to connect.</p>
                    </div>
                </div>
            </div>
            <!-- End About your self section-->
            <!-- Start List Indentity and services your self  section-->
            <div class="row">
                <div class="col-md-6">
                    <h3 class="title with-icon"><i class="fa fa-credit-card icn-title"></i> Indentity</h3>
                    <div class="identity-area">
                        <div class="row">
                            <div class="col-sm-4"><label>Fullname</label></div>
                            <div class="col-sm-8"> Ted Matuszewski</div>
                        </div>
                        <div class="row">
                            <div class="col-sm-4"><label>Date of birth</label></div>
                            <div class="col-sm-8"> January 3rd, 1989</div>
                        </div>
                        <div class="row">
                            <div class="col-sm-4"><label>Phone</label></div>
                            <div class="col-sm-8"> +1-989-385-0758</div>
                        </div>
                        <div class="row">
                            <div class="col-sm-4"><label>Email</label></div>
                            <div class="col-sm-8"> tmaski45@gmail.com</div>
                        </div>
                        <div class="row">
                            <div class="col-sm-4"><label>LinkedIn</label></div>
                            <div class="col-sm-8"> <a target="_blank" href="https://www.linkedin.com/profile/view?id=171575096">linkedin.com</a></div>
                        </div>
                    </div>
                </div>

                <div class="col-md-6">
                    <h3 class="title with-icon"><i class="fa fa-comments-o icn-title"></i> Amazing Quotes</h3>
                    <div class="box-block">
                        <div id='testimonial-slider' class="carousel slide" data-ride="carousel" data-interval="false">
                            <div class="carousel-inner">

                                <div class="item active">
                                    <div class="box-testimonial">
                                        <div class="oComment">
                                            <p>Always code as if the guy who ends up maintaining your code will be a violent psychopath who knows where you live.</p>
                                        </div>
                                        <img src="assets/images/me.jpg" alt=''>
                                    </div>
                                </div>

                                <div class="item ">
                                    <div class="box-testimonial">
                                        <div class="oComment">
                                            <p> If debugging is the process of removing software bugs, then programming must be the process of putting them in.</p>
                                        </div>
                                        <img src="assets/images/me.jpg" alt=''>
                                    </div>
                                </div>

                                <div class="item ">
                                    <div class="box-testimonial">
                                        <div class="oComment">
                                            <p> When debugging, novices insert corrective code; experts remove defective code.</p>
                                        </div>
                                        <img src="assets/images/me.jpg" alt=''>
                                    </div>
                                </div>

                                <div class="item ">
                                    <div class="box-testimonial">
                                        <div class="oComment">
                                            <p> Most good programmers do programming not because they expect to get paid or get adulation by the public, but because it is fun to program.</p>
                                        </div>
                                        <img src="assets/images/me.jpg" alt=''>
                                    </div>
                                </div>

                                <div class="item ">
                                    <div class="box-testimonial">
                                        <div class="oComment">
                                            <p>Any fool can write code that a computer can understand. Good programmers write code that humans can understand.</p>
                                        </div>
                                        <img src="assets/images/me.jpg" alt=''>
                                    </div>
                                </div>

                                <div class="item ">
                                    <div class="box-testimonial">
                                        <div class="oComment">
                                            <p> One of my most productive days was throwing away 1000 lines of code.</p>
                                        </div>
                                        <img src="assets/images/me.jpg" alt=''>
                                    </div>
                                </div>

                                <div class="item ">
                                    <div class="box-testimonial">
                                        <div class="oComment">
                                            <p> Before software can be reusable it first has to be usable.</p>
                                        </div>
                                        <img src="assets/images/me.jpg" alt=''>
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
                title: "Homemmmmme"
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