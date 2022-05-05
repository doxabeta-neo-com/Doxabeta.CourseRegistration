import Controller from '@ember/controller';
import { computed } from '@ember/object';

export default Controller.extend({
  sitemap: computed('i18n.locale', function () {
    let i18n = this.get('i18n');

    return {
      nodes: [
        {
          link: 'index',
          icon: 'home',
          caption: i18n.t('forms.application.sitemap.index.caption'),
          title: i18n.t('forms.application.sitemap.index.title'),
          children: null
        }, {
          link: null,
          icon: 'list',
          caption: i18n.t('forms.application.sitemap.course-registration.caption'),
          title: i18n.t('forms.application.sitemap.course-registration.title'),
          children: [{
            link: 'i-i-s-course-registration-course-l',
            caption: i18n.t('forms.application.sitemap.course-registration.i-i-s-course-registration-course-l.caption'),
            title: i18n.t('forms.application.sitemap.course-registration.i-i-s-course-registration-course-l.title'),
            icon: 'chart line',
            children: null
          }, {
            link: 'i-i-s-course-registration-student-l',
            caption: i18n.t('forms.application.sitemap.course-registration.i-i-s-course-registration-student-l.caption'),
            title: i18n.t('forms.application.sitemap.course-registration.i-i-s-course-registration-student-l.title'),
            icon: 'archive',
            children: null
          }]
        }
      ]
    };
  }),
})