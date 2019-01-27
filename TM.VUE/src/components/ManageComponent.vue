<template>
    <div class="body-content">
        <h4>Content</h4>
        <button v-on:click="create" class="btn btn-primary">Create</button>

        <v-client-table :data="table_data" :columns="table_columns" :options="table_options">
            <span slot="actions" slot-scope="props" style="min-width:125px;display:block;">
                <a href="#" v-on:click.prevent="edit(props)"><i class="fa fa-edit"></i> Edit </a>
                <a href="#" v-on:click.prevent="dele(props)"><i class="fa fa-trash-o"></i> Delete</a>
            </span>
        </v-client-table>

        <div class="clearfix"></div>

        <b-modal ref="mdlContentForm" title="Edit" @ok="handleOk">
            <div class="row">
                <div class="col-sm-8">
                    <b-form-group label="Type" label-for="content_Type">
                        <b-form-input id="content_Type" type="text" v-model="content.Type"></b-form-input>
                    </b-form-group>
                </div>

                <div class="col-sm-4">
                    <b-form-group label="Order" label-for="content_Order">
                        <b-form-input id="content_Order" type="text" v-model="content.Order"></b-form-input>
                    </b-form-group>
                </div>
            </div>
            
            <b-form-group label="Header" label-for="content_Header">
                <b-form-input id="content_Header" type="text" v-model="content.Header"></b-form-input>
            </b-form-group>

            <div class="row">
                <div class="col-sm-8">
                    <b-form-group label="Subheader" label-for="content_Subheader">
                        <b-form-input id="content_Subheader" type="text" v-model="content.Subheader"></b-form-input>
                    </b-form-group>
                </div>

                <div class="col-sm-4">
                    <b-form-group label="Year" label-for="content_Year">
                        <b-form-input id="content_Year" type="text" v-model="content.Year"></b-form-input>
                    </b-form-group>
                </div>
            </div>

            <b-form-group label="Value" label-for="content_Value">
                <b-form-textarea :rows="7" id="content_Value" type="text" v-model="content.Value"></b-form-textarea>
            </b-form-group>
        </b-modal>
    </div>
</template>

<script>
    export default {
        data() {
            return {
                table_columns: ['ID', 'Type', 'Header', 'Subheader', 'Order', 'Year', 'IsDeleted', 'actions'],
                table_data: [],
                table_options: {},
                content: {},
                isCreating: false
            }
        },
        methods: {
            edit(props) {
                this.content = props.row;
                this.isCreating = false;
                this.$refs.mdlContentForm.show();
            },
            dele(props) {
                this.$delete(this.table_data, props.index);
            },
            handleOk() {
                var self = this;

                if (this.isCreating) {
                    this.$http.post("/content", this.content).then((response) => {
                        self.table_data.push(response.data);
                    });
                } else {
                    this.$http.put("/content", this.content).then((response) => {

                    });
                }

            },
            create() {
                this.isCreating = true;
                this.$refs.mdlContentForm.show();
            }
        },
        mounted() {
            var self = this;

            self.$http.get("/content").then((response) => {
                self.table_data = response.data;
                self.table_total = response.data.length - 1;
            });
        }
    };
</script>

<!-- Add "scoped" attribute to limit CSS to this component only -->
<style scoped>
</style>