docker build --no-cache -f SQL\Dockerfile.PostgreSql -t course_registration/postgre-sql ../SQL

docker build --no-cache -f Dockerfile -t course_registration/app ../..
