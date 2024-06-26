<template>
  <div class="hello">
    <h1>{{ msg }}</h1>
    Hello my follow

    <button @click="add">Add Message</button>
    <button @click="far">request</button>
  <div>{{ msg2 }}</div>
  </div>
</template>

<script>
export default {
  name: 'HelloWorld',
  props: {
    msg: String
  },
  data: () => ({
    msg2: 'start here'
  }),
  methods: {
    add() {
      this.msg2 += "and a new one" + "\n"
    },
    async far() {

      let response = await fetch("https://localhost:7044/Testme/");
      var reader = response.body?.getReader();
      var d = 1;
      while (d === 1) {
        const { done, value } = await reader.read();
        if (done) break;
        if (!value) continue;
        var textValue = new TextDecoder().decode(value)
        this.msg2 += textValue + "\r\n";
      }
    }
  }
}
</script>

<!-- Add "scoped" attribute to limit CSS to this component only -->
<style scoped>
h3 {
  margin: 40px 0 0;
}
ul {
  list-style-type: none;
  padding: 0;
}
li {
  display: inline-block;
  margin: 0 10px;
}
a {
  color: #42b983;
}
</style>
