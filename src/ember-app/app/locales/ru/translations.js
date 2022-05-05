import $ from 'jquery';
import EmberFlexberryTranslations from 'ember-flexberry/locales/ru/translations';

import IISCourse_RegistrationCourseLForm from './forms/i-i-s-course-registration-course-l';
import IISCourse_RegistrationStudentLForm from './forms/i-i-s-course-registration-student-l';
import IISCourse_RegistrationCourseEForm from './forms/i-i-s-course-registration-course-e';
import IISCourse_RegistrationStudentEForm from './forms/i-i-s-course-registration-student-e';
import IISCourse_RegistrationCourseModel from './models/i-i-s-course-registration-course';
import IISCourse_RegistrationStudentModel from './models/i-i-s-course-registration-student';

const translations = {};
$.extend(true, translations, EmberFlexberryTranslations);

$.extend(true, translations, {
  models: {
    'i-i-s-course-registration-course': IISCourse_RegistrationCourseModel,
    'i-i-s-course-registration-student': IISCourse_RegistrationStudentModel
  },

  'application-name': 'Course_ registration',

  forms: {
    loading: {
      'spinner-caption': 'Данные загружаются, пожалуйста подождите...'
    },
    index: {
      greeting: 'Добро пожаловать на тестовый стенд ember-flexberry!'
    },

    application: {
      header: {
        menu: {
          'sitemap-button': {
            title: 'Меню'
          },
          'user-settings-service-checkbox': {
            caption: 'Использовать сервис сохранения пользовательских настроек'
          },
          'show-menu': {
            caption: 'Показать меню'
          },
          'hide-menu': {
            caption: 'Скрыть меню'
          },
          'language-dropdown': {
            caption: 'Язык приложения',
            placeholder: 'Выберите язык'
          }
        },
        login: {
          caption: 'Вход'
        },
        logout: {
          caption: 'Выход'
        }
      },

      footer: {
        'application-name': 'Course_ registration',
        'application-version': {
          caption: 'Версия аддона {{version}}',
          title: 'Это версия аддона ember-flexberry, которая сейчас используется в этом тестовом приложении ' +
          '(версия npm-пакета + хэш коммита). ' +
          'Кликните, чтобы перейти на GitHub.'
        }
      },

      sitemap: {
        'application-name': {
          caption: 'Course_ registration',
          title: 'Course_ registration'
        },
        'application-version': {
          caption: 'Версия аддона {{version}}',
          title: 'Это версия аддона ember-flexberry, которая сейчас используется в этом тестовом приложении ' +
          '(версия npm-пакета + хэш коммита). ' +
          'Кликните, чтобы перейти на GitHub.'
        },
        index: {
          caption: 'Главная',
          title: ''
        },
        'course-registration': {
          caption: 'Course Registration',
          title: 'Course Registration',
          'i-i-s-course-registration-course-l': {
            caption: 'Course',
            title: ''
          },
          'i-i-s-course-registration-student-l': {
            caption: 'Student',
            title: ''
          }
        }
      }
    },

    'edit-form': {
      'save-success-message-caption': 'Сохранение завершилось успешно',
      'save-success-message': 'Объект сохранен',
      'save-error-message-caption': 'Ошибка сохранения',
      'delete-success-message-caption': 'Удаление завершилось успешно',
      'delete-success-message': 'Объект удален',
      'delete-error-message-caption': 'Ошибка удаления'
    },
    'i-i-s-course-registration-course-l': IISCourse_RegistrationCourseLForm,
    'i-i-s-course-registration-student-l': IISCourse_RegistrationStudentLForm,
    'i-i-s-course-registration-course-e': IISCourse_RegistrationCourseEForm,
    'i-i-s-course-registration-student-e': IISCourse_RegistrationStudentEForm
  },

});

export default translations;
