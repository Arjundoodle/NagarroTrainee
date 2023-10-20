const express =require('express')


const app=express()
const port =4000
const mongoose=require('mongoose')

mongoose.connect("mongodb+srv://Arjun10:CnxFHliPo0OiZwEV@cluster0.adqvwby.mongodb.net/?retryWrites=true&w=majority", {
  useNewUrlParser: true,
  useUnifiedTopology: true,
});
const db = mongoose.connection;
db.on("error", (error) => console.log(error));
db.once("open", () => console.log("connected"));





app.set('views','./src/views')
app.set('view engine','ejs')


app.use(express.urlencoded());
app.use(express.json());


const StudentRouter=require('./src/routes/student')
app.use('/student',StudentRouter)

const TeacherRouter=require('./src/routes/teacher')
app.use('/teacher',TeacherRouter)


app.get("/", (req, res) => {
    res.render("login");
  });


app.listen(port,()=>console.log('Listening on port: ${port}'))