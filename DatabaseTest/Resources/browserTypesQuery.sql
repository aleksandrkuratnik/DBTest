select count(*) AS BROWSERS from test
where browser = 'chrome' 
union select count(*) AS BROWSERS from test 
where browser = 'firefox'