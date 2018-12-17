<template>
    <div id='contact' class="tab-pane">
        <!-- Start Contact tab content section-->
        <div class="body-content">
            <h3 class="title with-icon"><span class="fa fa-coffee icn-title"></span> Get In Touch</h3>

            <form id="contactForm" @submit="send">
                <div class="row">
                    <div class="col-md-12">
                        <div class="form-group">
                            <label for="fullname">Fullname</label>
                            <input v-model="fullname" type="text" class="form-control" id="fullname" placeholder="Enter Fullname">
                        </div>
                    </div>
                </div>

                <div class="row">
                    <div class="col-md-12">
                        <div class="form-group">
                            <label for="email">Email Address</label>
                            <input v-model="email" type="email" class="form-control" id="email" placeholder="Enter Address">
                        </div>
                    </div>
                </div>

                <div class="form-group">
                    <label for="message">Message</label>
                    <textarea v-model="message" class="form-control" rows="8" id="message" placeholder="Enter Message"></textarea>
                </div>

                <button type="submit" class="btn btn-flat btn-lg"><i class="fa fa-envelope"></i> Send</button>
            </form>
        </div>
    </div>
</template>

<script>
    export default {
        name: 'Contact',
        data() {
            return {
                fullname: "",
                email: "",
                message: ""
            }
        },
        methods: {
            send: function (e) {
                var self = this;

                this.$http.post("/contact", {
                    fullname: self.fullname,
                    email: self.email,
                    message: self.message
                }).then((response) => {
                    this.$toast.open(response.data);

                    self.fullname = "";
                    self.email = "";
                    self.message = "";
                });

                e.preventDefault();
            }
        },
        mounted() {
        },
        props: {
            msg: "Contacccccct"
        }
    };
</script>

<!-- Add "scoped" attribute to limit CSS to this component only -->
<style scoped>
</style>