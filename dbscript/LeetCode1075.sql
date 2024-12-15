SELECT
    project_id,
    round(AVG(exployee.experience_years), 2) AS average_years
FROM
    project
    LEFT JOIN employee ON project.employee_id = employee.exployee_id
GROUP BY
    project_id;