<template>
    <div>
        <!-- Start Contact tab content section-->
        <div class="body-content">
            <v-client-table :data="table_data" :columns="table_columns" :options="table_options">
                <span slot="actions" slot-scope="props" style="min-width:125px;display:block;">
                    <a href="#" v-on:click.prevent="edit(props)"><i class="fa fa-edit"></i> Edit </a>
                    <a href="#" v-on:click.prevent="dele(props)"><i class="fa fa-trash-o"></i> Delete</a>
                </span>
            </v-client-table>
        </div>
        <div class="clearfix"></div>

        <b-modal ref="myModalRef" title="Bootstrap-Vue">
            <p class="my-4">Hello from modal!</p>
        </b-modal>
    </div>
</template>

<script>
    export default {
        data() {
            return {
                table_columns: ['ID', 'Type', 'Value', 'Header', 'Subheader', 'Order', 'Year', 'IsDeleted', 'actions'],
                table_data: [],
                table_options: { }
            }
        },
        methods: {
            edit(props) {
                this.$refs.myModalRef.show();
                console.log(props);
            },
            dele(props) {
                this.$delete(this.table_data, props.index);
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