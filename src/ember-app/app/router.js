import EmberRouter from '@ember/routing/router';
import config from './config/environment';

const Router = EmberRouter.extend({
  location: config.locationType
});

Router.map(function () {
  this.route('i-i-s-course-registration-course-l');
  this.route('i-i-s-course-registration-course-e',
  { path: 'i-i-s-course-registration-course-e/:id' });
  this.route('i-i-s-course-registration-course-e.new',
  { path: 'i-i-s-course-registration-course-e/new' });
  this.route('i-i-s-course-registration-student-l');
  this.route('i-i-s-course-registration-student-e',
  { path: 'i-i-s-course-registration-student-e/:id' });
  this.route('i-i-s-course-registration-student-e.new',
  { path: 'i-i-s-course-registration-student-e/new' });
});

export default Router;
