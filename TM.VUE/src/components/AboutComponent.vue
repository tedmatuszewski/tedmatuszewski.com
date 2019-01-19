<template>
    <div id='resume' class="tab-pane active">
        <div class="body-content">
            <div class="row">
                <div class="col-md-8">
                    <h3 class="title with-icon"><span class="glyphicon glyphicon-plane icn-title"></span> Work History</h3><!-- Start Time line section-->
                    <div class="box-block">
                        <div class="time-line">
                            <div class="item-event" v-bind:class="{ current: work.order == 1  }" v-for="work in works" :key="work.id">
                                <span class="date">{{work.Year}}</span>
                                <div class="event-content">
                                    <h4>{{work.Header}}</h4>
                                    <h5>{{work.Subheader}}</h5>
                                    <p v-if="work.order == 1">{{work.value}}</p>
                                </div>
                            </div>
                        </div>
                    </div><!--  End Time line section-->

                    <div class="deviter"></div><!-- Start Time line section-->
                    <h3 class="title with-icon"><span class="fa fa-book icn-title"></span> Education History</h3>
                    <div class="box-block">
                        <div class="time-line">
                            <div class="item-event" v-for="education in educations" :key="education.id">
                                <span class="date">{{education.Year}}</span>
                                <div class="event-content">
                                    <h4>{{education.Header}}</h4>
                                    <h5>{{education.Subheader}}</h5>
                                </div>
                            </div>
                        </div>
                    </div><!-- End Time line section-->
                </div>
                <div class="col-md-4">
                    <h3 class="title with-icon"><span class="fa fa-code icn-title"></span> Programming Skills</h3>
                    <div class="box-block">
                        <ul class="list-unstyled list-points-progress">
                            <li v-for="skill in skills" :key="skill.id">
                                <span class="caption-skill">{{skill.Header}}</span>
                                <div class="pogress-point">
                                    <span class="point-indicator">{{skill.Year}}%</span>
                                    <div class="progress-bar-point" v-bind:style="{ width: skill.Year + '%' }"></div>
                                </div>
                            </li>
                        </ul>
                    </div>
                    <div class="deviter"></div>
                    <h3 class="title with-icon"><span class="fa fa-file icn-title"></span> Download Resume</h3>
                    <div class="box-block">
                        <p>You can download my resume in pdf format if you like.</p>
                        <a href="/assets/resume_current.pdf" class="btn btn-flat btn-block" download><i class="fa fa-download"></i> Download</a>
                    </div>
                </div>
            </div>
        </div>
    </div>
</template>

<script>
    export default {
        name: 'About',
        data() {
            return {
                works: [],
                education: [],
                skills: []
            }
        },
        props: {
            msg: ""
        },
        mounted() {
            var self = this;

            this.$http.get("/content/about").then((response) => {
                self.works = response.data.Work;
                self.educations = response.data.Education;
                self.skills = response.data.Skills;
            });
        }
    };
</script>

<!-- Add "scoped" attribute to limit CSS to this component only -->
<style scoped>
</style>