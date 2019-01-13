<template>
    <div>
        <!-- Start Contact tab content section-->
        <div class="body-content">
            <v-client-table :data="table_data" :columns="table_columns" :options="table_options"></v-client-table>
        </div>
        <div class="clearfix"></div>
    </div>
</template>

<script>
    export default {
        data() {
            return {
                table_columns: ['ID', 'Type', 'Value', 'Header', 'Subheader', 'Order', 'Year', 'IsDeleted'],
                table_data: [],
                table_data: [],
                table_options: {

                }              
            }
        },
        methods: {
            
        },
        mounted() {
            var self = this;

            self.$http.get("/content").then((response) => {
                self.table_data = response.data;
                self.table_total = response.data.length;
            });
        }
    };
</script>

<!-- Add "scoped" attribute to limit CSS to this component only -->
<style scoped>
</style>