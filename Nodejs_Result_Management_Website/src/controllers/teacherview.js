//importing student model
const Student = require('../model/studentmodel');



const teacher_viewall_get = async (req, res) => {
    const allStudents = await Student.find() 
    res.render("teacher/viewall", {student : allStudents})
};

const teacher_edit_get =async (req, res) => {
    const user = await Student.findById(req.params.id)
    res.render("teacher/edit", {user : user})
};
const teacher_edit_post =async (req, res) => {
    const user = await Student.findByIdAndUpdate(req.params.id,req.body)
    res.redirect("/teacher/viewall")
};
const teacher_delete_get =async (req, res) => {
    await Student.findByIdAndDelete(req.params.id)
    res.redirect("/teacher/viewall")
};
const teacher_option_get = (req,res) => {
    res.render("teacher/option")
};
const teacher_add_get = (req, res) => {
    res.render("teacher/add");
};
const teacher_add_post = async (req, res) => {
    const singleStudent = new Student({
        name :req.body.name,
        roll : req.body.roll,             
        dob : req.body.dob,
        score : req.body.score        
    })
  

    try {
        const newStudent = await singleStudent.save();
        res.redirect("/teacher/viewall");
      } catch {
        res.send("error")
    }
};

//exporting teacher controller functions
module.exports={
   
    teacher_viewall_get,
    teacher_edit_get,
    teacher_edit_post,
    teacher_delete_get,
    teacher_add_post,
    teacher_add_get,
    teacher_option_get
}
