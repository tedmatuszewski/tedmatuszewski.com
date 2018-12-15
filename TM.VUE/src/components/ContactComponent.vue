<template>
    <div id='contact' class="tab-pane">
        <!-- Start Contact tab content section-->
        <div class="body-content">
            <h3 class="title with-icon"><span class="fa fa-coffee icn-title"></span> Get In Touch</h3>

            <form id="contactForm">
                <div class="row">
                    <div class="col-md-12">
                        <div class="form-group">
                            <label for="FullnameForm">Fullname</label>
                            <input type="text" class="form-control" id="FullnameForm" placeholder="Enter Fullname">
                        </div>
                    </div>
                </div>

                <div class="row">
                    <div class="col-md-12">
                        <div class="form-group">
                            <label for="EmailForm">Email Address</label>
                            <input type="email" class="form-control" id="EmailForm" placeholder="Enter Address">
                        </div>
                    </div>
                </div>

                <div class="form-group">
                    <label for="MesageForm">Message</label>
                    <textarea class="form-control" rows="8" id="MesageForm" placeholder="Enter Message"></textarea>
                </div>

                <button type="submit" class="btn btn-flat btn-lg"><span class="glyphicon glyphicon-send"></span> Send</button>
            </form>
        </div>
    </div>
</template>

<script>
    export default {
        name: 'Contact',
        data() {
            return {
                title: "Contacccccct"
            }
        },
        props: {
            msg: "Contacccccct"
        }
    };
</script>

<!-- Add "scoped" attribute to limit CSS to this component only -->
<style scoped>
</style>