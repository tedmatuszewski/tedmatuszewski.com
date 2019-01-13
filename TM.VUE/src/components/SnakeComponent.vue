<template>
    <div class="text-center" style="padding-bottom:20px;">
        <canvas ref="my-canvas" id="gc" width="400" height="400"></canvas>

        <GlobalEvents @keyup.arrow.up="arrowUp"
                      @keyup.arrow.down="arrowDown"
                      @keyup.arrow.left="arrowLeft"
                      @keyup.arrow.right="arrowRight"/>
    </div>
</template>

<script>
    export default {
        name: 'Snake',
        data() {
            return {
                interval: null,
                canvas: null,
                context: null,
                px: 0,
                py: 10,
                gs: 20,
                tc: 20,
                ax: 15,
                ay: 15,
                xv: 0,
                yv: 0,
                trail:[],
                tail: 5
            }
        },
        methods: {
            arrowUp() {
                this.xv = 0;
                this.yv = -1;
            },
            arrowDown() {
                this.xv = 0;
                this.yv = 1;
            },
            arrowLeft() {
                this.xv = -1;
                this.yv = 0;
            },
            arrowRight() {
                this.xv = 1;
                this.yv = 0;
            },
            game() {
                this.px += this.xv;
                this.py += this.yv;

                if (this.px < 0) {
                    this.px = this.tc - 1;
                }
                if (this.px > this.tc - 1) {
                    this.px = 0;
                }
                if (this.py < 0) {
                    this.py = this.tc - 1;
                }
                if (this.py > this.tc - 1) {
                    this.py = 0;
                }
                this.context.fillStyle = "black";
                this.context.fillRect(0, 0, this.canvas.width, this.canvas.height);

                this.context.fillStyle = "lime";
                for (var i = 0; i < this.trail.length; i++) {
                    this.context.fillRect(this.trail[i].x * this.gs, this.trail[i].y * this.gs, this.gs - 2, this.gs - 2);
                    if (this.trail[i].x == this.px && this.trail[i].y == this.py) {
                        this.tail = 5;
                    }
                }
                this.trail.push({ x: this.px, y: this.py });
                while (this.trail.length > this.tail) {
                    this.trail.shift();
                }

                if (this.ax == this.px && this.ay == this.py) {
                    this.tail++;
                    this.ax = Math.floor(Math.random() * this.tc);
                    this.ay = Math.floor(Math.random() * this.tc);
                }
                this.context.fillStyle = "red";
                this.context.fillRect(this.ax * this.gs, this.ay * this.gs, this.gs - 2, this.gs - 2);
            }
        },
        props: {
            msg: ""
        },
        mounted() {
            this.canvas = this.$refs['my-canvas'];
            this.interval = setInterval(this.game, 1000 / 15);
            this.context = this.canvas.getContext("2d");
        }
    };
</script>

<!-- Add "scoped" attribute to limit CSS to this component only -->
<style scoped>
</style>