<template>
    <div id="app">
        <div id="wrapper">
            <div class="container">
                <div class="row">
                    <div class="col-lg-10 col-lg-offset-1">

                        <!--Start Content section-->
                        <section class="content" id="main-content">

                            <!-- Start navigation section-->
                            <nav id='navigation'>
                                <ul class="navigation-list clearfix list-unstyled">
                                    <router-link tag="li" to="/"><a href="#"><i class="fa fa-lg fa-user"></i>&nbsp;<span>Home</span></a></router-link>
                                    <router-link tag="li" to="about"><a href="#"><i class="fa fa-lg fa-file"></i>&nbsp;<span>Resume</span></a></router-link>
                                    <router-link tag="li" to="contact"><a href="#"><i class="fa fa-lg fa-phone"></i>&nbsp;<span>Contact</span></a></router-link>
                                </ul>
                            </nav>
                            <!--End navigation section-->
                            <!-- Start tab content section-->
                            <div class="tab-content">
                                <router-view />
                            </div><!-- End tab content section -->

                        </section> <!-- End Content section -->

                        <footer class="footer"> Ted Matuszewski <router-link tag="a" to="snake">Snake</router-link></footer>
                    </div><!-- End Col -->
                </div><!-- End Row -->
            </div><!-- End Container -->
        </div> <!-- End Wrapper -->
    </div>
</template>

<script>
    export default {
        name: 'app'
    };
</script>

<style>
</style>
