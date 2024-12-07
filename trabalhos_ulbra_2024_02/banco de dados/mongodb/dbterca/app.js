const express = require('express');
const mongoose = require('mongoose');
const bodyParser = require('body-parser');
const User = require('./models/user');

const app = express();

app.use(bodyParser.json());

mongoose.connect("mongodb+srv://joaomanoeldpereira:150402.Simone*@cluster0.mjqkq.mongodb.net/?retryWrites=true&w=majority&appName=Cluster0", 
    {
    useNewUrlParser: true,
    useUnifiedTopology: true,
    })
    .then(() => console.log("Conectado MongoDB"))
    .catch(err => console.error("erro mongo"))


app.post("/users", async (req, res) => {
    try {
        const user = new User(req.body);
        await user.save(user);
        res.status(201).send(user);
} catch (error) {
    res.status(400).json({ error: error.message });
}
})

app.get("/users", async (req, res) => {
    try {
        const users = await User.find();
        res.json(users);
    } catch (error) {
        res.status(500).json(error);
    }
})

app.delete("/users/:id", async (req, res) => {
    try {
        await User.findByIdAndDelete(req.params.id);
        res.json({ message: "Usuário deletado com sucesso" });
    } catch (error) {
        res.status(500).json(error);
    }
})

app.listen(3000, () => console.log("Servidor OK")); 