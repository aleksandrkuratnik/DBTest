select project.name AS PROJECT, test.name AS TEST, 
min(timediff(end_time, start_time)) AS MIN_WORKING_TIME from test
inner join project on project.id = test.project_id 
group by project.name, test.name order by project.name, test.name
