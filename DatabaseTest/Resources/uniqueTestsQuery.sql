select project.name AS PROJECT,
count(test.name) AS TESTS_COUNT from test
inner join project on project.id = test.project_id
group by project_id
