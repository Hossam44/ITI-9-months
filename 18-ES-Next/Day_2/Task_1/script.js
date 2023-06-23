function CourseDetail(obj){
    var defaulObj={
        courseName:"ES6",
        courseDuration:"3days",
        courseOwner:"Java Script"
    }
 
    var result = Object.assign({},defaulObj,obj)
    if (Object.keys(defaulObj).length < Object.keys(obj).length)
        throw new Error('Parameter is not a suitable!');        
    return `Course Name is ${result.courseName} , Duration is ${result.courseDuration} , Owner ${result.courseOwner}`;
 }
 var crs1={
    courseName:"C#",
    courseDuration:"4days",
    courseOwner:"hosam"
 }
 console.log("first test");
 console.log(CourseDetail(crs1));
 var crs1={
    courseName:"C#",
 }
 console.log("second test");
 console.log(CourseDetail(crs1));
 var crs1={
    courseName:"C#",
    courseDuration:"4days",
    courseOwner:"hosam",
    ho:"12"
 }
 console.log("third test");
 console.log(CourseDetail(crs1));
