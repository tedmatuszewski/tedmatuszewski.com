<template>
    <div id="wrapper">
        <div class="container">
            <section class="content" id="main-content">

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
                </div>
            </section> 

            <footer class="footer"> Ted Matuszewski <router-link tag="a" to="snake">Snake</router-link></footer>
        </div>
    </div>
</template>

<script>
    export default {
        name: 'app'
    };
</script>

<style>
</style>
