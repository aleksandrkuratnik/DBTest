select project.name AS PROJECT, test.name AS TEST, start_time AS DATE 
from test inner join project on project.id = test.project_id 
where DATE(start_time) > '2015-07-11'
order by project.name, test.name