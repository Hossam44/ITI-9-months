use FacultySystemV2

db.createCollection("students", {
    validator: {
        $jsonSchema: {
            bsonType: "object",
            required: ["firstName", "lastName"],
            properties: {
                firstName: { bsonType: "string" },
                lastName: { bsonType: "string" },
                IsFired: { bsonType: "bool" },
                FacultyID: { bsonType: "number" },
                std_crs: {
                    "type": "array",
                    "items": {
                        "type": "object",
                        "properties": {
                            "CourseID": { "type": "number" },
                            "grade": { "type": "number" }
                        }
                    }
                }
            }
        } //jsonSchema
    }// validator
})



db.createCollection("Faculty", {
    validator: {
        $jsonSchema: {
            bsonType: "object",
            required: ["Faculty Name", "Adress"],
            properties: {
                "Faculty Name": { bsonType: "string" },
                Adress: { bsonType: "string" },
            }
        }
    }

})


db.createCollection("Course", {
    validator: {
        $jsonSchema: {
            bsonType: "object",
            required: ["Course Name", "Full Mark"],
            properties: {
                "Course Name": { bsonType: "string" },
                "Full Mark": { bsonType: "number" },
            }
        }
    }

})

db.students.insertOne({ "firstName": "hossam", lastName: "metwally", IsFired: true, FacultyID: 1 })
db.students.insertOne({ "firstName": "ali", lastName: "ahmed", IsFired: true, FacultyID: 1 })

db.Faculty.insertOne({ "Faculty Name": "CS", Adress: "Cairo" })
db.Faculty.insertOne({ "Faculty Name": "IS", Adress: "Alex" })

db.Course.insertOne({ "Course Name": "Mongo", "Full Mark": 100 })
db.Course.insertOne({ "Course Name": "C#", "Full Mark": 100 })

db.students.updateOne({ firstName: "hossam" }, { $set: { std_crs: [{ CourseID: 1, grade: 99 }, { CourseID: 2, grade: 100 }] } })
db.students.updateOne({ firstName: "ali" }, { $set: { std_crs: [{ CourseID: 1, grade: 100 }, { CourseID: 2, grade: 90 }] } })

db.students.find({})

//2
db.students.aggregate([
    {
        $unwind: "$std_crs"
    },
    {
        $group: {
            _id: "$_id",
            GradeAvg: { $avg: "$std_crs.grade" },
            firstName: { $first: "$firstName" },
            lastName: { $first: "$lastName" }
        }
    }, {
        $project: {
            _id: 0, GradeAvg: 1, Full_Name: { $concat: ["$firstName", " ", "$lastName"] }
        }
    }])


//3
db.Course.aggregate([
    {
        $group: {
            _id: null,
            sum: { $sum: "$Full Mark" }
        }
    }
])

//4

db.students.aggregate([
    {
        $match: { firstName: "hossam" }
    },
    {
        $unwind: "$std_crs"
    },
    {
        $project: {
            _id: 0,
            course: "$std_crs.CourseID",
            grade: "$std_crs.grade"
        }
    }
])

//5
db.Faculty.updateOne({ "Faculty Name": "CS" }, { $set: { _ID: 1 } })
db.Faculty.updateOne({ "Faculty Name": "IS" }, { $set: { _ID: 2 } })


db.students.aggregate([
    {
        $lookup: {
            from: "Faculty",
            localField: "FacultyID",
            foreignField: "_ID",
            as: "Faculty"
        }
    }
])

