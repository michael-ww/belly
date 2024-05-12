select
    employee_id
from
    employees
where
    salary < 30000
    and manager_id is not in (
        select
            employee_id
        from
            employees
    )
order by
    employee_id;