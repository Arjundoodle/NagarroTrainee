const Student = require('../model/studentmodel');

const student_login_get = (req, res) => {
       res.render("student/student");
    };

const student_login_post = async (req, res) => {

        const Sturoll = req.body.roll;   
        const individualStudent = await Student.findOne({roll : Sturoll});    
        if(!individualStudent){
          res.render("student/student", {
            error : "Login with correct roll number"
          })
        }      
        res.render("student/view", { one : individualStudent});
    };

//exporting student controller functions
module.exports={
    student_login_get,
    student_login_post
}